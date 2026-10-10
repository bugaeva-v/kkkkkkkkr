using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x0200000E RID: 14
	internal class CharVector : IDisposable, IEnumerable, IList<byte>, ICollection<byte>, IEnumerable<byte>
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00003B0B File Offset: 0x00001D0B
		internal CharVector(IntPtr cPtr, bool cMemoryOwn)
		{
			this.swigCMemOwn = cMemoryOwn;
			this.swigCPtr = new HandleRef(this, cPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003B2C File Offset: 0x00001D2C
		internal static HandleRef getCPtr(CharVector obj)
		{
			return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003B54 File Offset: 0x00001D54
		internal static HandleRef swigRelease(CharVector obj)
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

		// Token: 0x06000097 RID: 151 RVA: 0x00003BAC File Offset: 0x00001DAC
		~CharVector()
		{
			this.Dispose(false);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003BE0 File Offset: 0x00001DE0
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003BF4 File Offset: 0x00001DF4
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
						AppUtilPINVOKE.delete_CharVector(this.swigCPtr);
					}
					this.swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003C84 File Offset: 0x00001E84
		public CharVector(IEnumerable c) : this()
		{
			bool flag = c == null;
			if (flag)
			{
				throw new ArgumentNullException("c");
			}
			foreach (object obj in c)
			{
				byte x = (byte)obj;
				this.Add(x);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public CharVector(IEnumerable<byte> c) : this()
		{
			bool flag = c == null;
			if (flag)
			{
				throw new ArgumentNullException("c");
			}
			foreach (byte x in c)
			{
				this.Add(x);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003D60 File Offset: 0x00001F60
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003D74 File Offset: 0x00001F74
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700001B RID: 27
		public byte this[int index]
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003DB0 File Offset: 0x00001FB0
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00003DC8 File Offset: 0x00001FC8
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003E00 File Offset: 0x00002000
		public bool IsEmpty
		{
			get
			{
				return this.empty();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003E18 File Offset: 0x00002018
		public int Count
		{
			get
			{
				return (int)this.size();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003E30 File Offset: 0x00002030
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003E43 File Offset: 0x00002043
		public void CopyTo(byte[] array)
		{
			this.CopyTo(0, array, 0, this.Count);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003E56 File Offset: 0x00002056
		public void CopyTo(byte[] array, int arrayIndex)
		{
			this.CopyTo(0, array, arrayIndex, this.Count);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003E6C File Offset: 0x0000206C
		public void CopyTo(int index, byte[] array, int arrayIndex, int count)
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

		// Token: 0x060000A8 RID: 168 RVA: 0x00003F50 File Offset: 0x00002150
		public byte[] ToArray()
		{
			byte[] array = new byte[this.Count];
			this.CopyTo(array);
			return array;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003F78 File Offset: 0x00002178
		IEnumerator<byte> IEnumerable<byte>.GetEnumerator()
		{
			return new CharVector.CharVectorEnumerator(this);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003F90 File Offset: 0x00002190
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new CharVector.CharVectorEnumerator(this);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003FA8 File Offset: 0x000021A8
		public CharVector.CharVectorEnumerator GetEnumerator()
		{
			return new CharVector.CharVectorEnumerator(this);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003FC0 File Offset: 0x000021C0
		public CharVector() : this(AppUtilPINVOKE.new_CharVector__SWIG_0(), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003FEC File Offset: 0x000021EC
		public CharVector(CharVector other) : this(AppUtilPINVOKE.new_CharVector__SWIG_1(CharVector.getCPtr(other)), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000401C File Offset: 0x0000221C
		public void Clear()
		{
			AppUtilPINVOKE.CharVector_Clear(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004048 File Offset: 0x00002248
		public void Add(byte x)
		{
			AppUtilPINVOKE.CharVector_Add(this.swigCPtr, x);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004074 File Offset: 0x00002274
		private uint size()
		{
			uint result = AppUtilPINVOKE.CharVector_size(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000040A4 File Offset: 0x000022A4
		private bool empty()
		{
			bool result = AppUtilPINVOKE.CharVector_empty(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000040D4 File Offset: 0x000022D4
		private uint capacity()
		{
			uint result = AppUtilPINVOKE.CharVector_capacity(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004104 File Offset: 0x00002304
		private void reserve(uint n)
		{
			AppUtilPINVOKE.CharVector_reserve(this.swigCPtr, n);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004130 File Offset: 0x00002330
		public CharVector(int capacity) : this(AppUtilPINVOKE.new_CharVector__SWIG_2(capacity), true)
		{
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000415C File Offset: 0x0000235C
		private byte getitemcopy(int index)
		{
			byte result = AppUtilPINVOKE.CharVector_getitemcopy(this.swigCPtr, index);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000418C File Offset: 0x0000238C
		private byte getitem(int index)
		{
			byte result = AppUtilPINVOKE.CharVector_getitem(this.swigCPtr, index);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000041BC File Offset: 0x000023BC
		private void setitem(int index, byte val)
		{
			AppUtilPINVOKE.CharVector_setitem(this.swigCPtr, index, val);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000041E8 File Offset: 0x000023E8
		public void AddRange(CharVector values)
		{
			AppUtilPINVOKE.CharVector_AddRange(this.swigCPtr, CharVector.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004218 File Offset: 0x00002418
		public CharVector GetRange(int index, int count)
		{
			IntPtr intPtr = AppUtilPINVOKE.CharVector_GetRange(this.swigCPtr, index, count);
			CharVector result = (intPtr == IntPtr.Zero) ? null : new CharVector(intPtr, true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004260 File Offset: 0x00002460
		public void Insert(int index, byte x)
		{
			AppUtilPINVOKE.CharVector_Insert(this.swigCPtr, index, x);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000428C File Offset: 0x0000248C
		public void InsertRange(int index, CharVector values)
		{
			AppUtilPINVOKE.CharVector_InsertRange(this.swigCPtr, index, CharVector.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000042BC File Offset: 0x000024BC
		public void RemoveAt(int index)
		{
			AppUtilPINVOKE.CharVector_RemoveAt(this.swigCPtr, index);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000042E8 File Offset: 0x000024E8
		public void RemoveRange(int index, int count)
		{
			AppUtilPINVOKE.CharVector_RemoveRange(this.swigCPtr, index, count);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004314 File Offset: 0x00002514
		public static CharVector Repeat(byte value, int count)
		{
			IntPtr intPtr = AppUtilPINVOKE.CharVector_Repeat(value, count);
			CharVector result = (intPtr == IntPtr.Zero) ? null : new CharVector(intPtr, true);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004358 File Offset: 0x00002558
		public void Reverse()
		{
			AppUtilPINVOKE.CharVector_Reverse__SWIG_0(this.swigCPtr);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004384 File Offset: 0x00002584
		public void Reverse(int index, int count)
		{
			AppUtilPINVOKE.CharVector_Reverse__SWIG_1(this.swigCPtr, index, count);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000043B0 File Offset: 0x000025B0
		public void SetRange(int index, CharVector values)
		{
			AppUtilPINVOKE.CharVector_SetRange(this.swigCPtr, index, CharVector.getCPtr(values));
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000043E0 File Offset: 0x000025E0
		public bool Contains(byte value)
		{
			bool result = AppUtilPINVOKE.CharVector_Contains(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004410 File Offset: 0x00002610
		public int IndexOf(byte value)
		{
			int result = AppUtilPINVOKE.CharVector_IndexOf(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004440 File Offset: 0x00002640
		public int LastIndexOf(byte value)
		{
			int result = AppUtilPINVOKE.CharVector_LastIndexOf(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004470 File Offset: 0x00002670
		public bool Remove(byte value)
		{
			bool result = AppUtilPINVOKE.CharVector_Remove(this.swigCPtr, value);
			bool pending = AppUtilPINVOKE.SWIGPendingException.Pending;
			if (pending)
			{
				throw AppUtilPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		// Token: 0x04000027 RID: 39
		private HandleRef swigCPtr;

		// Token: 0x04000028 RID: 40
		protected bool swigCMemOwn;

		// Token: 0x02000024 RID: 36
		public sealed class CharVectorEnumerator : IEnumerator, IEnumerator<byte>, IDisposable
		{
			// Token: 0x060002AB RID: 683 RVA: 0x00008C33 File Offset: 0x00006E33
			public CharVectorEnumerator(CharVector collection)
			{
				this.collectionRef = collection;
				this.currentIndex = -1;
				this.currentObject = null;
				this.currentSize = this.collectionRef.Count;
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060002AC RID: 684 RVA: 0x00008C64 File Offset: 0x00006E64
			public byte Current
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
					return (byte)this.currentObject;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060002AD RID: 685 RVA: 0x00008CD0 File Offset: 0x00006ED0
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060002AE RID: 686 RVA: 0x00008CF0 File Offset: 0x00006EF0
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

			// Token: 0x060002AF RID: 687 RVA: 0x00008D64 File Offset: 0x00006F64
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

			// Token: 0x060002B0 RID: 688 RVA: 0x00008DA6 File Offset: 0x00006FA6
			public void Dispose()
			{
				this.currentIndex = -1;
				this.currentObject = null;
			}

			// Token: 0x04000077 RID: 119
			private CharVector collectionRef;

			// Token: 0x04000078 RID: 120
			private int currentIndex;

			// Token: 0x04000079 RID: 121
			private object currentObject;

			// Token: 0x0400007A RID: 122
			private int currentSize;
		}
	}
}
