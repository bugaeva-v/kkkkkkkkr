using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x0200000C RID: 12
	internal class StringStringMap : IDisposable, IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002AB2 File Offset: 0x00000CB2
		internal StringStringMap(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002AD0 File Offset: 0x00000CD0
		internal static HandleRef getCPtr(StringStringMap obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002AF8 File Offset: 0x00000CF8
		internal static HandleRef swigRelease(StringStringMap obj)
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

		// Token: 0x06000042 RID: 66 RVA: 0x00002B50 File Offset: 0x00000D50
		~StringStringMap()
		{
			this.Dispose(false);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002B84 File Offset: 0x00000D84
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002B98 File Offset: 0x00000D98
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
						AppUtilPINVOKE.delete_StringStringMap(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x1700000C RID: 12
		public string this[string key]
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

		// Token: 0x06000047 RID: 71 RVA: 0x00002C50 File Offset: 0x00000E50
		public bool TryGetValue(string key, out string value)
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002C80 File Offset: 0x00000E80
		public bool IsEmpty
		{
			get
			{
				return this.empty();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002C98 File Offset: 0x00000E98
		public int Count
		{
			get
			{
				return (int)this.size();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public ICollection<string> Keys
		{
			get
			{
				ICollection<string> collection = new List<string>();
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002D28 File Offset: 0x00000F28
		public ICollection<string> Values
		{
			get
			{
				ICollection<string> collection = new List<string>();
				foreach (KeyValuePair<string, string> keyValuePair in this)
				{
					collection.Add(keyValuePair.Value);
				}
				return collection;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002D88 File Offset: 0x00000F88
		public void Add(KeyValuePair<string, string> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002DA0 File Offset: 0x00000FA0
		public bool Remove(KeyValuePair<string, string> item)
		{
			bool flag = this.Contains(item);
			return flag && this.Remove(item.Key);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public bool Contains(KeyValuePair<string, string> item)
		{
			return this[item.Key] == item.Value;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002E06 File Offset: 0x00001006
		public void CopyTo(KeyValuePair<string, string>[] array)
		{
			this.CopyTo(array, 0);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002E14 File Offset: 0x00001014
		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
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
			IList<string> list = new List<string>(this.Keys);
			for (int i = 0; i < list.Count; i++)
			{
				string key = list[i];
				array.SetValue(new KeyValuePair<string, string>(key, this[key]), arrayIndex + i);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002EDC File Offset: 0x000010DC
		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
		{
			return new StringStringMap.StringStringMapEnumerator(this);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002EF4 File Offset: 0x000010F4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StringStringMap.StringStringMapEnumerator(this);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002F0C File Offset: 0x0000110C
		public StringStringMap.StringStringMapEnumerator GetEnumerator()
		{
			return new StringStringMap.StringStringMapEnumerator(this);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002F24 File Offset: 0x00001124
		public StringStringMap() : this(AppUtilPINVOKE.new_StringStringMap__SWIG_0(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002F50 File Offset: 0x00001150
		public StringStringMap(StringStringMap other) : this(AppUtilPINVOKE.new_StringStringMap__SWIG_1(StringStringMap.getCPtr(other)), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002F80 File Offset: 0x00001180
		private uint size()
		{
			uint result = AppUtilPINVOKE.StringStringMap_size(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002FB0 File Offset: 0x000011B0
		private bool empty()
		{
			bool result = AppUtilPINVOKE.StringStringMap_empty(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002FE0 File Offset: 0x000011E0
		public void Clear()
		{
			AppUtilPINVOKE.StringStringMap_Clear(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000300C File Offset: 0x0000120C
		private string getitem(string key)
		{
			string result = AppUtilPINVOKE.StringStringMap_getitem(this.swigCPtr, key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000303C File Offset: 0x0000123C
		private void setitem(string key, string x)
		{
			AppUtilPINVOKE.StringStringMap_setitem(this.swigCPtr, key, x);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003068 File Offset: 0x00001268
		public bool ContainsKey(string key)
		{
			bool result = AppUtilPINVOKE.StringStringMap_ContainsKey(this.swigCPtr, key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003098 File Offset: 0x00001298
		public void Add(string key, string value)
		{
			AppUtilPINVOKE.StringStringMap_Add(this.swigCPtr, key, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000030C4 File Offset: 0x000012C4
		public bool Remove(string key)
		{
			bool result = AppUtilPINVOKE.StringStringMap_Remove(this.swigCPtr, key);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000030F4 File Offset: 0x000012F4
		private IntPtr create_iterator_begin()
		{
			IntPtr result = AppUtilPINVOKE.StringStringMap_create_iterator_begin(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003124 File Offset: 0x00001324
		private string get_next_key(IntPtr swigiterator)
		{
			string result = AppUtilPINVOKE.StringStringMap_get_next_key(this.swigCPtr, swigiterator);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003154 File Offset: 0x00001354
		private void destroy_iterator(IntPtr swigiterator)
		{
			AppUtilPINVOKE.StringStringMap_destroy_iterator(this.swigCPtr, swigiterator);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x04000023 RID: 35
		private HandleRef swigCPtr;

		// Token: 0x04000024 RID: 36
		protected bool swigCMemOwn;

		// Token: 0x02000022 RID: 34
		public sealed class StringStringMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<string, string>>, IDisposable
		{
			// Token: 0x0600029F RID: 671 RVA: 0x00008908 File Offset: 0x00006B08
			public StringStringMapEnumerator(StringStringMap collection)
			{
				this.collectionRef = collection;
				this.keyCollection = new List<string>(collection.Keys);
				this.currentIndex = -1;
				this.currentObject = null;
				this.currentSize = this.collectionRef.Count;
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x00008954 File Offset: 0x00006B54
			public KeyValuePair<string, string> Current
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
					return (KeyValuePair<string, string>)this.currentObject;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060002A1 RID: 673 RVA: 0x000089C0 File Offset: 0x00006BC0
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x000089E0 File Offset: 0x00006BE0
			public bool MoveNext()
			{
				int count = this.collectionRef.Count;
				bool flag = this.currentIndex + 1 < count && count == this.currentSize;
				bool flag2 = flag;
				if (flag2)
				{
					this.currentIndex++;
					string key = this.keyCollection[this.currentIndex];
					this.currentObject = new KeyValuePair<string, string>(key, this.collectionRef[key]);
				}
				else
				{
					this.currentObject = null;
				}
				return flag;
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x00008A68 File Offset: 0x00006C68
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

			// Token: 0x060002A4 RID: 676 RVA: 0x00008AAA File Offset: 0x00006CAA
			public void Dispose()
			{
				this.currentIndex = -1;
				this.currentObject = null;
			}

			// Token: 0x0400006E RID: 110
			private StringStringMap collectionRef;

			// Token: 0x0400006F RID: 111
			private IList<string> keyCollection;

			// Token: 0x04000070 RID: 112
			private int currentIndex;

			// Token: 0x04000071 RID: 113
			private object currentObject;

			// Token: 0x04000072 RID: 114
			private int currentSize;
		}
	}
}
