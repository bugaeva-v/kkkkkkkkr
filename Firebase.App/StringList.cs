using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x0200000D RID: 13
	internal class StringList : IDisposable, IEnumerable, IList<string>, ICollection<string>, IEnumerable<string>
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000317E File Offset: 0x0000137E
		internal StringList(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000319C File Offset: 0x0000139C
		internal static HandleRef getCPtr(StringList obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000031C4 File Offset: 0x000013C4
		internal static HandleRef swigRelease(StringList obj)
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

		// Token: 0x06000065 RID: 101 RVA: 0x0000321C File Offset: 0x0000141C
		~StringList()
		{
			this.Dispose(false);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003250 File Offset: 0x00001450
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003264 File Offset: 0x00001464
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
						AppUtilPINVOKE.delete_StringList(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000032F4 File Offset: 0x000014F4
		public StringList(IEnumerable c) : this()
		{
			bool flag = c == null;
			if (flag)
			{
				throw new ArgumentNullException("c");
			}
			foreach (object obj in c)
			{
				string x = (string)obj;
				this.Add(x);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003368 File Offset: 0x00001568
		public StringList(IEnumerable<string> c) : this()
		{
			bool flag = c == null;
			if (flag)
			{
				throw new ArgumentNullException("c");
			}
			foreach (string x in c)
			{
				this.Add(x);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000033D0 File Offset: 0x000015D0
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000033E4 File Offset: 0x000015E4
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000014 RID: 20
		public string this[int index]
		{
			get
			{
				return this.getitem(index);
			}
			set
			{
				this.setitem(index, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003420 File Offset: 0x00001620
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00003438 File Offset: 0x00001638
		public int Capacity
		{
			get
			{
				return (int)this.capacity();
			}
			set
			{
				bool flag = value < 0 || value < (int)this.size();
				if (flag)
				{
					throw new ArgumentOutOfRangeException("Capacity");
				}
				this.reserve((uint)value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003470 File Offset: 0x00001670
		public bool IsEmpty
		{
			get
			{
				return this.empty();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003488 File Offset: 0x00001688
		public int Count
		{
			get
			{
				return (int)this.size();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000034A0 File Offset: 0x000016A0
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000034B3 File Offset: 0x000016B3
		public void CopyTo(string[] array)
		{
			this.CopyTo(0, array, 0, this.Count);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000034C6 File Offset: 0x000016C6
		public void CopyTo(string[] array, int arrayIndex)
		{
			this.CopyTo(0, array, arrayIndex, this.Count);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000034DC File Offset: 0x000016DC
		public void CopyTo(int index, string[] array, int arrayIndex, int count)
		{
			bool flag = array == null;
			if (flag)
			{
				throw new ArgumentNullException("array");
			}
			bool flag2 = index < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", "Value is less than zero");
			}
			bool flag3 = arrayIndex < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Value is less than zero");
			}
			bool flag5 = array.Rank > 1;
			if (flag5)
			{
				throw new ArgumentException("Multi dimensional array.", "array");
			}
			bool flag6 = index + count > this.Count || arrayIndex + count > array.Length;
			if (flag6)
			{
				throw new ArgumentException("Number of elements to copy is too large.");
			}
			for (int i = 0; i < count; i++)
			{
				array.SetValue(this.getitemcopy(index + i), arrayIndex + i);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000035BC File Offset: 0x000017BC
		public string[] ToArray()
		{
			string[] array = new string[this.Count];
			this.CopyTo(array);
			return array;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000035E4 File Offset: 0x000017E4
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return new StringList.StringListEnumerator(this);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000035FC File Offset: 0x000017FC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StringList.StringListEnumerator(this);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003614 File Offset: 0x00001814
		public StringList.StringListEnumerator GetEnumerator()
		{
			return new StringList.StringListEnumerator(this);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000362C File Offset: 0x0000182C
		public StringList() : this(AppUtilPINVOKE.new_StringList__SWIG_0(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003658 File Offset: 0x00001858
		public StringList(StringList other) : this(AppUtilPINVOKE.new_StringList__SWIG_1(StringList.getCPtr(other)), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003688 File Offset: 0x00001888
		public void Clear()
		{
			AppUtilPINVOKE.StringList_Clear(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000036B4 File Offset: 0x000018B4
		public void Add(string x)
		{
			AppUtilPINVOKE.StringList_Add(this.swigCPtr, x);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000036E0 File Offset: 0x000018E0
		private uint size()
		{
			uint result = AppUtilPINVOKE.StringList_size(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003710 File Offset: 0x00001910
		private bool empty()
		{
			bool result = AppUtilPINVOKE.StringList_empty(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003740 File Offset: 0x00001940
		private uint capacity()
		{
			uint result = AppUtilPINVOKE.StringList_capacity(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003770 File Offset: 0x00001970
		private void reserve(uint n)
		{
			AppUtilPINVOKE.StringList_reserve(this.swigCPtr, n);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000379C File Offset: 0x0000199C
		public StringList(int capacity) : this(AppUtilPINVOKE.new_StringList__SWIG_2(capacity), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000037C8 File Offset: 0x000019C8
		private string getitemcopy(int index)
		{
			string result = AppUtilPINVOKE.StringList_getitemcopy(this.swigCPtr, index);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000037F8 File Offset: 0x000019F8
		private string getitem(int index)
		{
			string result = AppUtilPINVOKE.StringList_getitem(this.swigCPtr, index);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003828 File Offset: 0x00001A28
		private void setitem(int index, string val)
		{
			AppUtilPINVOKE.StringList_setitem(this.swigCPtr, index, val);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003854 File Offset: 0x00001A54
		public void AddRange(StringList values)
		{
			AppUtilPINVOKE.StringList_AddRange(this.swigCPtr, StringList.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003884 File Offset: 0x00001A84
		public StringList GetRange(int index, int count)
		{
			IntPtr intPtr = AppUtilPINVOKE.StringList_GetRange(this.swigCPtr, index, count);
			StringList result = (intPtr == IntPtr.Zero) ? null : new StringList(intPtr, true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000038CC File Offset: 0x00001ACC
		public void Insert(int index, string x)
		{
			AppUtilPINVOKE.StringList_Insert(this.swigCPtr, index, x);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000038F8 File Offset: 0x00001AF8
		public void InsertRange(int index, StringList values)
		{
			AppUtilPINVOKE.StringList_InsertRange(this.swigCPtr, index, StringList.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003928 File Offset: 0x00001B28
		public void RemoveAt(int index)
		{
			AppUtilPINVOKE.StringList_RemoveAt(this.swigCPtr, index);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003954 File Offset: 0x00001B54
		public void RemoveRange(int index, int count)
		{
			AppUtilPINVOKE.StringList_RemoveRange(this.swigCPtr, index, count);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003980 File Offset: 0x00001B80
		public static StringList Repeat(string value, int count)
		{
			IntPtr intPtr = AppUtilPINVOKE.StringList_Repeat(value, count);
			StringList result = (intPtr == IntPtr.Zero) ? null : new StringList(intPtr, true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000039C4 File Offset: 0x00001BC4
		public void Reverse()
		{
			AppUtilPINVOKE.StringList_Reverse__SWIG_0(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000039F0 File Offset: 0x00001BF0
		public void Reverse(int index, int count)
		{
			AppUtilPINVOKE.StringList_Reverse__SWIG_1(this.swigCPtr, index, count);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003A1C File Offset: 0x00001C1C
		public void SetRange(int index, StringList values)
		{
			AppUtilPINVOKE.StringList_SetRange(this.swigCPtr, index, StringList.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003A4C File Offset: 0x00001C4C
		public bool Contains(string value)
		{
			bool result = AppUtilPINVOKE.StringList_Contains(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003A7C File Offset: 0x00001C7C
		public int IndexOf(string value)
		{
			int result = AppUtilPINVOKE.StringList_IndexOf(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003AAC File Offset: 0x00001CAC
		public int LastIndexOf(string value)
		{
			int result = AppUtilPINVOKE.StringList_LastIndexOf(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003ADC File Offset: 0x00001CDC
		public bool Remove(string value)
		{
			bool result = AppUtilPINVOKE.StringList_Remove(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x04000025 RID: 37
		private HandleRef swigCPtr;

		// Token: 0x04000026 RID: 38
		protected bool swigCMemOwn;

		// Token: 0x02000023 RID: 35
		public sealed class StringListEnumerator : IEnumerator, IEnumerator<string>, IDisposable
		{
			// Token: 0x060002A5 RID: 677 RVA: 0x00008ABB File Offset: 0x00006CBB
			public StringListEnumerator(StringList collection)
			{
				this.collectionRef = collection;
				this.currentIndex = -1;
				this.currentObject = null;
				this.currentSize = this.collectionRef.Count;
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060002A6 RID: 678 RVA: 0x00008AEC File Offset: 0x00006CEC
			public string Current
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
					return (string)this.currentObject;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x00008B58 File Offset: 0x00006D58
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00008B70 File Offset: 0x00006D70
			public bool MoveNext()
			{
				int count = this.collectionRef.Count;
				bool flag = this.currentIndex + 1 < count && count == this.currentSize;
				bool flag2 = flag;
				if (flag2)
				{
					this.currentIndex++;
					this.currentObject = this.collectionRef[this.currentIndex];
				}
				else
				{
					this.currentObject = null;
				}
				return flag;
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00008BE0 File Offset: 0x00006DE0
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

			// Token: 0x060002AA RID: 682 RVA: 0x00008C22 File Offset: 0x00006E22
			public void Dispose()
			{
				this.currentIndex = -1;
				this.currentObject = null;
			}

			// Token: 0x04000073 RID: 115
			private StringList collectionRef;

			// Token: 0x04000074 RID: 116
			private int currentIndex;

			// Token: 0x04000075 RID: 117
			private object currentObject;

			// Token: 0x04000076 RID: 118
			private int currentSize;
		}
	}
}
