using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase.Analytics
{
	// Token: 0x02000007 RID: 7
	internal class IntIntMap : IDisposable, IDictionary<int, int>, ICollection<KeyValuePair<int, int>>, IEnumerable<KeyValuePair<int, int>>, IEnumerable
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002B50 File Offset: 0x00000D50
		internal IntIntMap(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002B70 File Offset: 0x00000D70
		internal static HandleRef getCPtr(IntIntMap obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B98 File Offset: 0x00000D98
		internal static HandleRef swigRelease(IntIntMap obj)
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

		// Token: 0x06000031 RID: 49 RVA: 0x00002BF0 File Offset: 0x00000DF0
		~IntIntMap()
		{
			this.Dispose(false);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002C24 File Offset: 0x00000E24
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002C38 File Offset: 0x00000E38
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
						FirebaseAnalyticsInternalPINVOKE.delete_IntIntMap(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x17000004 RID: 4
		public int this[int key]
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

		// Token: 0x06000036 RID: 54 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public bool TryGetValue(int key, out int value)
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
				value = 0;
				result = false;
			}
			return result;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002D20 File Offset: 0x00000F20
		public bool IsEmpty
		{
			get
			{
				return this.empty();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002D38 File Offset: 0x00000F38
		public int Count
		{
			get
			{
				return (int)this.size();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002D50 File Offset: 0x00000F50
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002D64 File Offset: 0x00000F64
		public ICollection<int> Keys
		{
			get
			{
				ICollection<int> collection = new List<int>();
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public ICollection<int> Values
		{
			get
			{
				ICollection<int> collection = new List<int>();
				foreach (KeyValuePair<int, int> keyValuePair in this)
				{
					collection.Add(keyValuePair.Value);
				}
				return collection;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E28 File Offset: 0x00001028
		public void Add(KeyValuePair<int, int> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002E40 File Offset: 0x00001040
		public bool Remove(KeyValuePair<int, int> item)
		{
			bool flag = this.Contains(item);
			return flag && this.Remove(item.Key);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002E70 File Offset: 0x00001070
		public bool Contains(KeyValuePair<int, int> item)
		{
			return this[item.Key] == item.Value;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002EA3 File Offset: 0x000010A3
		public void CopyTo(KeyValuePair<int, int>[] array)
		{
			this.CopyTo(array, 0);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002EB0 File Offset: 0x000010B0
		public void CopyTo(KeyValuePair<int, int>[] array, int arrayIndex)
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
			IList<int> list = new List<int>(this.Keys);
			for (int i = 0; i < list.Count; i++)
			{
				int key = list[i];
				array.SetValue(new KeyValuePair<int, int>(key, this[key]), arrayIndex + i);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002F78 File Offset: 0x00001178
		IEnumerator<KeyValuePair<int, int>> IEnumerable<KeyValuePair<int, int>>.GetEnumerator()
		{
			return new IntIntMap.IntIntMapEnumerator(this);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002F90 File Offset: 0x00001190
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IntIntMap.IntIntMapEnumerator(this);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002FA8 File Offset: 0x000011A8
		public IntIntMap.IntIntMapEnumerator GetEnumerator()
		{
			return new IntIntMap.IntIntMapEnumerator(this);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002FC0 File Offset: 0x000011C0
		public IntIntMap() : this(FirebaseAnalyticsInternalPINVOKE.new_IntIntMap__SWIG_0(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002FEC File Offset: 0x000011EC
		public IntIntMap(IntIntMap other) : this(FirebaseAnalyticsInternalPINVOKE.new_IntIntMap__SWIG_1(IntIntMap.getCPtr(other)), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000301C File Offset: 0x0000121C
		private uint size()
		{
			uint result = FirebaseAnalyticsInternalPINVOKE.IntIntMap_size(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000304C File Offset: 0x0000124C
		private bool empty()
		{
			bool result = FirebaseAnalyticsInternalPINVOKE.IntIntMap_empty(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000307C File Offset: 0x0000127C
		public void Clear()
		{
			FirebaseAnalyticsInternalPINVOKE.IntIntMap_Clear(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000030A8 File Offset: 0x000012A8
		private int getitem(int key)
		{
			int result = FirebaseAnalyticsInternalPINVOKE.IntIntMap_getitem(this.swigCPtr, key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000030D8 File Offset: 0x000012D8
		private void setitem(int key, int x)
		{
			FirebaseAnalyticsInternalPINVOKE.IntIntMap_setitem(this.swigCPtr, key, x);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003104 File Offset: 0x00001304
		public bool ContainsKey(int key)
		{
			bool result = FirebaseAnalyticsInternalPINVOKE.IntIntMap_ContainsKey(this.swigCPtr, key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003134 File Offset: 0x00001334
		public void Add(int key, int value)
		{
			FirebaseAnalyticsInternalPINVOKE.IntIntMap_Add(this.swigCPtr, key, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003160 File Offset: 0x00001360
		public bool Remove(int key)
		{
			bool result = FirebaseAnalyticsInternalPINVOKE.IntIntMap_Remove(this.swigCPtr, key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003190 File Offset: 0x00001390
		private IntPtr create_iterator_begin()
		{
			IntPtr result = FirebaseAnalyticsInternalPINVOKE.IntIntMap_create_iterator_begin(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000031C0 File Offset: 0x000013C0
		private int get_next_key(IntPtr swigiterator)
		{
			int result = FirebaseAnalyticsInternalPINVOKE.IntIntMap_get_next_key(this.swigCPtr, swigiterator);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000031F0 File Offset: 0x000013F0
		private void destroy_iterator(IntPtr swigiterator)
		{
			FirebaseAnalyticsInternalPINVOKE.IntIntMap_destroy_iterator(this.swigCPtr, swigiterator);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0400007B RID: 123
		private HandleRef swigCPtr;

		// Token: 0x0400007C RID: 124
		protected bool swigCMemOwn;

		// Token: 0x0200000D RID: 13
		public sealed class IntIntMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<int, int>>, IDisposable
		{
			// Token: 0x06000099 RID: 153 RVA: 0x00003600 File Offset: 0x00001800
			public IntIntMapEnumerator(IntIntMap collection)
			{
				this.collectionRef = collection;
				this.keyCollection = new List<int>(collection.Keys);
				this.currentIndex = -1;
				this.currentObject = null;
				this.currentSize = this.collectionRef.Count;
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600009A RID: 154 RVA: 0x0000364C File Offset: 0x0000184C
			public KeyValuePair<int, int> Current
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
					return (KeyValuePair<int, int>)this.currentObject;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600009B RID: 155 RVA: 0x000036B8 File Offset: 0x000018B8
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x0600009C RID: 156 RVA: 0x000036D8 File Offset: 0x000018D8
			public bool MoveNext()
			{
				int count = this.collectionRef.Count;
				bool flag = this.currentIndex + 1 < count && count == this.currentSize;
				bool flag2 = flag;
				if (flag2)
				{
					this.currentIndex++;
					int key = this.keyCollection[this.currentIndex];
					this.currentObject = new KeyValuePair<int, int>(key, this.collectionRef[key]);
				}
				else
				{
					this.currentObject = null;
				}
				return flag;
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00003760 File Offset: 0x00001960
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

			// Token: 0x0600009E RID: 158 RVA: 0x000037A2 File Offset: 0x000019A2
			public void Dispose()
			{
				this.currentIndex = -1;
				this.currentObject = null;
			}

			// Token: 0x04000082 RID: 130
			private IntIntMap collectionRef;

			// Token: 0x04000083 RID: 131
			private IList<int> keyCollection;

			// Token: 0x04000084 RID: 132
			private int currentIndex;

			// Token: 0x04000085 RID: 133
			private object currentObject;

			// Token: 0x04000086 RID: 134
			private int currentSize;
		}
	}
}
