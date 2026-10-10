using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x02000017 RID: 23
	internal class VariantVariantMap : IDisposable, IDictionary<Variant, Variant>, ICollection<KeyValuePair<Variant, Variant>>, IEnumerable<KeyValuePair<Variant, Variant>>, IEnumerable
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00006CA8 File Offset: 0x00004EA8
		internal VariantVariantMap(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006CC8 File Offset: 0x00004EC8
		internal static HandleRef getCPtr(VariantVariantMap obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006CF0 File Offset: 0x00004EF0
		internal static HandleRef swigRelease(VariantVariantMap obj)
		{
			bool flag = obj != null;
			HandleRef result;
			if (flag)
			{
				bool flag2 = !obj.swigCMemOwn;
				if (flag2)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef handleRef = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				result = handleRef;
			}
			else
			{
				result = new HandleRef(null, IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006D48 File Offset: 0x00004F48
		~VariantVariantMap()
		{
			this.Dispose(false);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006D7C File Offset: 0x00004F7C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006D90 File Offset: 0x00004F90
		public virtual void Dispose(bool disposing)
		{
			object disposeLock = FirebaseApp.disposeLock;
			lock (disposeLock)
			{
				bool flag2 = this.swigCPtr.Handle != IntPtr.Zero;
				if (flag2)
				{
					bool flag3 = this.swigCMemOwn;
					if (flag3)
					{
						this.swigCMemOwn = false;
						AppUtilPINVOKE.delete_VariantVariantMap(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x17000030 RID: 48
		public Variant this[Variant key]
		{
			get
			{
				return this.getitem(key);
			}
			set
			{
				this.setitem(key, value);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006E48 File Offset: 0x00005048
		public bool TryGetValue(Variant key, out Variant value)
		{
			bool flag = this.ContainsKey(key);
			bool result;
			if (flag)
			{
				value = this[key];
				result = true;
			}
			else
			{
				value = null;
				result = false;
			}
			return result;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00006E78 File Offset: 0x00005078
		public bool IsEmpty
		{
			get
			{
				return this.empty();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00006E90 File Offset: 0x00005090
		public int Count
		{
			get
			{
				return (int)this.size();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00006EA8 File Offset: 0x000050A8
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006EBC File Offset: 0x000050BC
		public ICollection<Variant> Keys
		{
			get
			{
				ICollection<Variant> collection = new List<Variant>();
				int count = this.Count;
				bool flag = count > 0;
				if (flag)
				{
					IntPtr swigiterator = this.create_iterator_begin();
					for (int i = 0; i < count; i++)
					{
						collection.Add(this.get_next_key(swigiterator));
					}
					this.destroy_iterator(swigiterator);
				}
				return collection;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00006F20 File Offset: 0x00005120
		public ICollection<Variant> Values
		{
			get
			{
				ICollection<Variant> collection = new List<Variant>();
				foreach (KeyValuePair<Variant, Variant> keyValuePair in this)
				{
					collection.Add(keyValuePair.Value);
				}
				return collection;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006F80 File Offset: 0x00005180
		public void Add(KeyValuePair<Variant, Variant> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00006F98 File Offset: 0x00005198
		public bool Remove(KeyValuePair<Variant, Variant> item)
		{
			bool flag = this.Contains(item);
			return flag && this.Remove(item.Key);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006FC8 File Offset: 0x000051C8
		public bool Contains(KeyValuePair<Variant, Variant> item)
		{
			return this[item.Key] == item.Value;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006FFB File Offset: 0x000051FB
		public void CopyTo(KeyValuePair<Variant, Variant>[] array)
		{
			this.CopyTo(array, 0);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00007008 File Offset: 0x00005208
		public void CopyTo(KeyValuePair<Variant, Variant>[] array, int arrayIndex)
		{
			bool flag = array == null;
			if (flag)
			{
				throw new ArgumentNullException("array");
			}
			bool flag2 = arrayIndex < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
			}
			bool flag3 = array.Rank > 1;
			if (flag3)
			{
				throw new ArgumentException("Multi dimensional array.", "array");
			}
			bool flag4 = arrayIndex + this.Count > array.Length;
			if (flag4)
			{
				throw new ArgumentException("Number of elements to copy is too large.");
			}
			IList<Variant> list = new List<Variant>(this.Keys);
			for (int i = 0; i < list.Count; i++)
			{
				Variant key = list[i];
				array.SetValue(new KeyValuePair<Variant, Variant>(key, this[key]), arrayIndex + i);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000070D0 File Offset: 0x000052D0
		IEnumerator<KeyValuePair<Variant, Variant>> IEnumerable<KeyValuePair<Variant, Variant>>.GetEnumerator()
		{
			return new VariantVariantMap.VariantVariantMapEnumerator(this);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000070E8 File Offset: 0x000052E8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new VariantVariantMap.VariantVariantMapEnumerator(this);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00007100 File Offset: 0x00005300
		public VariantVariantMap.VariantVariantMapEnumerator GetEnumerator()
		{
			return new VariantVariantMap.VariantVariantMapEnumerator(this);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00007118 File Offset: 0x00005318
		public VariantVariantMap() : this(AppUtilPINVOKE.new_VariantVariantMap__SWIG_0(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00007144 File Offset: 0x00005344
		public VariantVariantMap(VariantVariantMap other) : this(AppUtilPINVOKE.new_VariantVariantMap__SWIG_1(VariantVariantMap.getCPtr(other)), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007174 File Offset: 0x00005374
		private uint size()
		{
			uint result = AppUtilPINVOKE.VariantVariantMap_size(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000071A4 File Offset: 0x000053A4
		private bool empty()
		{
			bool result = AppUtilPINVOKE.VariantVariantMap_empty(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000071D4 File Offset: 0x000053D4
		public void Clear()
		{
			AppUtilPINVOKE.VariantVariantMap_Clear(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007200 File Offset: 0x00005400
		private Variant getitem(Variant key)
		{
			Variant result = new Variant(AppUtilPINVOKE.VariantVariantMap_getitem(this.swigCPtr, Variant.getCPtr(key)), false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000723C File Offset: 0x0000543C
		private void setitem(Variant key, Variant x)
		{
			AppUtilPINVOKE.VariantVariantMap_setitem(this.swigCPtr, Variant.getCPtr(key), Variant.getCPtr(x));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00007274 File Offset: 0x00005474
		public bool ContainsKey(Variant key)
		{
			bool result = AppUtilPINVOKE.VariantVariantMap_ContainsKey(this.swigCPtr, Variant.getCPtr(key));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000072A8 File Offset: 0x000054A8
		public void Add(Variant key, Variant value)
		{
			AppUtilPINVOKE.VariantVariantMap_Add(this.swigCPtr, Variant.getCPtr(key), Variant.getCPtr(value));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000072E0 File Offset: 0x000054E0
		public bool Remove(Variant key)
		{
			bool result = AppUtilPINVOKE.VariantVariantMap_Remove(this.swigCPtr, Variant.getCPtr(key));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007314 File Offset: 0x00005514
		private IntPtr create_iterator_begin()
		{
			IntPtr result = AppUtilPINVOKE.VariantVariantMap_create_iterator_begin(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007344 File Offset: 0x00005544
		private Variant get_next_key(IntPtr swigiterator)
		{
			Variant result = new Variant(AppUtilPINVOKE.VariantVariantMap_get_next_key(this.swigCPtr, swigiterator), false);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000737C File Offset: 0x0000557C
		private void destroy_iterator(IntPtr swigiterator)
		{
			AppUtilPINVOKE.VariantVariantMap_destroy_iterator(this.swigCPtr, swigiterator);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x04000061 RID: 97
		private HandleRef swigCPtr;

		// Token: 0x04000062 RID: 98
		protected bool swigCMemOwn;

		// Token: 0x02000035 RID: 53
		public sealed class VariantVariantMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<Variant, Variant>>, IDisposable
		{
			// Token: 0x060002EA RID: 746 RVA: 0x000091C0 File Offset: 0x000073C0
			public VariantVariantMapEnumerator(VariantVariantMap collection)
			{
				this.collectionRef = collection;
				this.keyCollection = new List<Variant>(collection.Keys);
				this.currentIndex = -1;
				this.currentObject = null;
				this.currentSize = this.collectionRef.Count;
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0000920C File Offset: 0x0000740C
			public KeyValuePair<Variant, Variant> Current
			{
				get
				{
					bool flag = this.currentIndex == -1;
					if (flag)
					{
						throw new InvalidOperationException("Enumeration not started.");
					}
					bool flag2 = this.currentIndex > this.currentSize - 1;
					if (flag2)
					{
						throw new InvalidOperationException("Enumeration finished.");
					}
					bool flag3 = this.currentObject == null;
					if (flag3)
					{
						throw new InvalidOperationException("Collection modified.");
					}
					return (KeyValuePair<Variant, Variant>)this.currentObject;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060002EC RID: 748 RVA: 0x00009278 File Offset: 0x00007478
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002ED RID: 749 RVA: 0x00009298 File Offset: 0x00007498
			public bool MoveNext()
			{
				int count = this.collectionRef.Count;
				bool flag = this.currentIndex + 1 < count && count == this.currentSize;
				bool flag2 = flag;
				if (flag2)
				{
					this.currentIndex++;
					Variant key = this.keyCollection[this.currentIndex];
					this.currentObject = new KeyValuePair<Variant, Variant>(key, this.collectionRef[key]);
				}
				else
				{
					this.currentObject = null;
				}
				return flag;
			}

			// Token: 0x060002EE RID: 750 RVA: 0x00009320 File Offset: 0x00007520
			public void Reset()
			{
				this.currentIndex = -1;
				this.currentObject = null;
				bool flag = this.collectionRef.Count != this.currentSize;
				if (flag)
				{
					throw new InvalidOperationException("Collection modified.");
				}
			}

			// Token: 0x060002EF RID: 751 RVA: 0x00009362 File Offset: 0x00007562
			public void Dispose()
			{
				this.currentIndex = -1;
				this.currentObject = null;
			}

			// Token: 0x04000090 RID: 144
			private VariantVariantMap collectionRef;

			// Token: 0x04000091 RID: 145
			private IList<Variant> keyCollection;

			// Token: 0x04000092 RID: 146
			private int currentIndex;

			// Token: 0x04000093 RID: 147
			private object currentObject;

			// Token: 0x04000094 RID: 148
			private int currentSize;
		}
	}
}
